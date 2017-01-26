﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plunder.Compoment;
using Plunder.Pipeline;
using log4net;

namespace Plunder.Plugin.Pipeline
{
    public class FileModule : IPipelineModule
    {
        public string Name => "文件存储模块";

        public string Description => "数据持久化到文件";

        public void Init(object context)
        {
            throw new NotImplementedException();
        }

        public async Task ProcessAsync(PageResult data)
        {
            await Task.Run(() =>
            {
                var newReqCount = data.NewRequests == null ? 0 : data.NewRequests.Count();
                var baseDir = AppDomain.CurrentDomain.BaseDirectory;
                File.AppendAllLines(baseDir + "page_result.txt", new List<string>() { String.Format("Url:{0}, StatusCode:{1}, New Request Count:{2}", data.Request.Url, data.Response.HttpStatusCode, newReqCount) }, Encoding.UTF8);
            });
            
        }
    }
}
