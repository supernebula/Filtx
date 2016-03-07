﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plunder.Compoment;

namespace Plunder.Pipeline
{
    public class ProducerModule : IResultPipelineModule
    {
        public string ModuleName
        {
            get { return "生产者模块"; }
        }

        public string ModuleDescription
        {
            get { return "从结果中发现新的url并封装为请求消息，交付给调度器消息队列"; }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(object context)
        {
            throw new NotImplementedException();
        }

        public void Process(PageResult result)
        {
            throw new NotImplementedException();
        }
    }
}