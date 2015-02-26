// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CsvActionResult.cs" company="Frame Digital">
//   Copyright Frame Digital
// </copyright>
// <summary>
//   Defines the CsvActionResult type.
// https://gist.github.com/simonech/4104490 - This code has been modified to do some extra functionality
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestingEventBriteApi.Infrastructure.CsvExport
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Text;
    using System.Web;
    using System.Web.Mvc;

    /// <summary>
    /// The csv action result.
    /// </summary>
    /// <typeparam name="T">
    /// Object to convert
    /// </typeparam>
    public class CsvActionResult<T> : FileResult where T : class 
    {
        /// <summary>
        /// The _list.
        /// </summary>
        private readonly IEnumerable<T> list;

        /// <summary>
        /// The _separator.
        /// </summary>
        private readonly char separator;

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvActionResult{T}"/> class.
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        /// <param name="fileDownloadName">
        /// The file download name.
        /// </param>
        /// <param name="separator">
        /// The separator.
        /// </param>
        public CsvActionResult(IEnumerable<T> list, string fileDownloadName, char separator = ',')
            : base("text/csv")
        {
            this.list = list;
            this.FileDownloadName = fileDownloadName;
            this.separator = separator;
        }

        /// <summary>
        /// The get property value.
        /// </summary>
        /// <param name="src">
        /// The src.
        /// </param>
        /// <param name="propName">
        /// The prop name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetPropertyValue(object src, string propName)
        {
            string value = string.Empty;

            if (src != null)
            {
                value = src.GetType().GetProperty(propName).GetValue(src, null).ToString();
            }

            return value;
        }

        /// <summary>
        /// The write file.
        /// </summary>
        /// <param name="response">
        /// The response.
        /// </param>
        protected override void WriteFile(HttpResponseBase response)
        {
            var outputStream = response.OutputStream;
            using (var memoryStream = new MemoryStream())
            {
                this.WriteList(memoryStream);
                outputStream.Write(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
            }
        }

        /// <summary>
        /// The write list.
        /// </summary>
        /// <param name="stream">
        /// The stream.
        /// </param>
        private void WriteList(Stream stream)
        {
            var streamWriter = new StreamWriter(stream, Encoding.Default);

            this.WriteHeaderLine(streamWriter);
            streamWriter.WriteLine();
            this.WriteDataLines(streamWriter);

            streamWriter.Flush();
        }

        /// <summary>
        /// The write header line.
        /// </summary>
        /// <param name="streamWriter">
        /// The stream writer.
        /// </param>
        private void WriteHeaderLine(StreamWriter streamWriter)
        {
            foreach (PropertyInfo member in typeof(T).GetProperties())
            {
                if (Attribute.GetCustomAttribute(member, typeof(NonCsvProperty)) == null)
                {
                    this.WriteProperties(streamWriter, typeof(T).GetProperties(), null);
                }
            }
        }

        /// <summary>
        /// The write properties.
        /// </summary>
        /// <param name="writer">
        /// The writer.
        /// </param>
        /// <param name="properties">
        /// The properties.
        /// </param>
        /// <param name="line">
        /// The line.
        /// </param>
        private void WriteProperties(StreamWriter writer, IEnumerable<PropertyInfo> properties, object line)
        {
            foreach (PropertyInfo property in properties)
            {
                if (Attribute.GetCustomAttribute(property, typeof(NonCsvProperty)) == null)
                {
                    Type t = property.PropertyType;
                    if (t.IsPrimitive || t == typeof(decimal) || t == typeof(string))
                    {
                        
                        this.WriteValue(writer, line != null ? GetPropertyValue(line, property.Name) : property.Name);

                        continue;
                    }

                    if (line != null)
                    {
                        this.WriteProperties(writer, t.GetProperties(), line.GetType().GetProperty(property.Name).GetValue(line, null));
                    }
                }
            }
        }

        /// <summary>
        /// The write data lines.
        /// </summary>
        /// <param name="streamWriter">
        /// The stream writer.
        /// </param>
        private void WriteDataLines(StreamWriter streamWriter)
        {
            foreach (var line in this.list)
            {
                this.WriteProperties(streamWriter, typeof(T).GetProperties(), line);
                streamWriter.WriteLine();
            }
        }

        /// <summary>
        /// The write value.
        /// </summary>
        /// <param name="writer">
        /// The writer.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="optionalText">
        /// Optional text to go before the value.
        /// </param>
        private void WriteValue(TextWriter writer, string value, string optionalText = "")
        {
            writer.Write("\"");
            writer.Write(string.Concat(optionalText, value.Replace("\"", "\"\"")));
            writer.Write("\"" + this.separator);
        }
    } 
}