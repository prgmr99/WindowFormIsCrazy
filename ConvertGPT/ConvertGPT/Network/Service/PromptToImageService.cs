using PlantUml.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGPT
{
    internal class PromptToImageService : PromptService
    {
        public PromptToImageService(string apikey) : base(apikey)
        {
        }
        public override async Task<string> GetResponse(IPromptType pit)
        {
            await base.GetResponse(pit);
            var factory = new RendererFactory();

            var renderer = factory.CreateRenderer(new PlantUmlSettings());
            Output = Output.Replace("```", "");
            var bytes = await renderer.RenderAsync(Output, OutputFormat.Png);
            File.WriteAllBytes("out.png", bytes);
            return Output;
        }
    }
}
