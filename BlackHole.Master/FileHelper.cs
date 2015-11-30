﻿using BlackHole.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackHole.Master
{
    /// <summary>
    /// 
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="slaveName"></param>
        /// <param name="fileName"></param>
        /// <param name="raw"></param>
        public static void WriteDownloadedPart(string directory, string fileName, long currentPart, byte[] rawData)
            => CommonHelper.WriteDownloadedPart(directory, fileName, currentPart, rawData);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="name"></param>
        /// <param name="raw"></param>
        public static void SaveFile(string directory, string name, byte[] raw)
        {
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);
            File.WriteAllBytes(Path.Combine("./", Path.Combine(directory, name)), raw);
        }
    }
}
