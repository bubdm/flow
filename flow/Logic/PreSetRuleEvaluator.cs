﻿using Mchnry.Flow.Diagnostics;
using Mchnry.Flow.Logic.Define;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Mchnry.Flow.Logic
{
    internal class PreSetRuleEvaluator<TModel> : IRuleEvaluator<TModel>
    {

        internal List<Rule> rules = new List<Rule>();

        public PreSetRuleEvaluator(List<Rule> toTest)
        {
            this.rules = toTest;
        }


        public Evaluator Definition => new Evaluator()
        {
            Id = "preset",
            Description = "Preset rule evaluator for testing"
        };

        public async Task EvaluateAsync(IEngineScope<TModel> scope, IEngineTrace trace, IRuleResult result, CancellationToken token)
        {
            //thinking out-loud
            //if single rule where truecondition == false, then isTrue = false, set result to false.  good that.
            //if multi-rules mixed... then or is inferred, so if any where truecondition == true, then result = true

            bool isTrue = this.rules.Any(a => a.TrueCondition);
            trace.TraceStep(string.Format("Preset:{0}", isTrue));
            result.SetResult(isTrue);
        }
    }
}

