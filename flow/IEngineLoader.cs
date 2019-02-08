﻿using Mchnry.Flow.Analysis;
using Mchnry.Flow.Logic;
using Mchnry.Flow.Work;
using System;
using System.Collections.Generic;
using WorkDefine = Mchnry.Flow.Work.Define;

namespace Mchnry.Flow
{
    public interface IEngineLoader
    {
        IEngineLoader SetModel<T>(string key, T model);
        IEngineLoader OverrideValidation(ValidationOverride oride);

        IEngineLoader SetEvaluatorFactory(IRuleEvaluatorFactory factory);
        IEngineLoader SetActionFactory(IActionFactory factory);

        IEngineRunner Start();
        LintResult Lint(Action<LogicLinter> addIntents);
        WorkDefine.Workflow Workflow { get; }
    }
}