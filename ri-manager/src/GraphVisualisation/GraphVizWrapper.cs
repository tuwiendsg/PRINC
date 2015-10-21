using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using GraphVizWrapper.Interfaces;
using System.Reflection;

namespace GraphVizWrapper
{
    public class GraphVizWrapper : IGraphVizWrapper
    {
        private static Enums.RenderingEngine _renderingEngine;

        public Enums.RenderingEngine RenderingEngine
        {
            get { return _renderingEngine; }
            set { _renderingEngine = value; }
        }

        //private static string FilePath { get { return AppPath + "\\" + ProcessFolder + "\\" + GetRenderingEngine(_renderingEngine) + ".exe"; }}

        private static string FilePath { get { return AppPath + "\\..\\..\\" + ProcessFolder + "\\" + GetRenderingEngine(_renderingEngine) + ".exe"; } }

        private const string ProcessFolder = "GraphViz";
        private const string ConfigFile = "config6";

        private static readonly string AppPath = Path.GetDirectoryName(Assembly.GetAssembly(typeof(GraphVizWrapper)).CodeBase).Remove(0, 6);
        

        public byte[] GenerateGraph(string dotFile, Enums.GraphReturnType returnType)
        {
            byte[] output;

            if(!ConfigExists())
                RegisterLayoutPlugin();

            string fileType = GetReturnType(returnType);

            var processStartInfo = new ProcessStartInfo(FilePath)
                                       {
                                           RedirectStandardInput = true,
                                           RedirectStandardOutput = true,
                                           RedirectStandardError = true,
                                           UseShellExecute = false,
                                           Arguments = "-v -o -T" + fileType,
                                           CreateNoWindow = true
                                       };
            
            using (var process = Process.Start(processStartInfo))
            {
                using(var stdIn = process.StandardInput)
                {
                    stdIn.WriteLine(dotFile);
                }

                using (var stdOut = process.StandardOutput)
                {
                    var baseStream = stdOut.BaseStream;
                    output = ReadFully(baseStream);
                }                
            }

            return output;
        }

        private static byte[] ReadFully(Stream input)
        {
            using (var ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        private static void RegisterLayoutPlugin()
        {
            var processStartInfo = new ProcessStartInfo(FilePath)
            {
                UseShellExecute = false,
                Arguments = "-c",
                CreateNoWindow = true
            };

            using (Process.Start(processStartInfo)){}
        }

        private static bool ConfigExists()
        {
            return File.Exists(AppPath + "\\" + ProcessFolder + "\\" + ConfigFile);
        }


        private static string GetReturnType(Enums.GraphReturnType returnType)
        {
            var nameValues = new Dictionary<Enums.GraphReturnType, string>
                                 {
                                     {Enums.GraphReturnType.Png, "png"},
                                     {Enums.GraphReturnType.Jpg, "jpg"},
                                     {Enums.GraphReturnType.Pdf, "pdf"}
                                 };
            return nameValues[returnType];
        }

        private static string GetRenderingEngine(Enums.RenderingEngine renderingEngine)
        {
            var nameValues = new Dictionary<Enums.RenderingEngine, string>
                                 {
                                     {Enums.RenderingEngine.Dot, "dot"},
                                     {Enums.RenderingEngine.Fdp, "fdp"},
                                     {Enums.RenderingEngine.Neato, "neato"}
                                 };
            return nameValues[renderingEngine];
        }
    }
}
