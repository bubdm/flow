﻿using System;
using System.Collections.Generic;
using System.Text;
using Mchnry.Flow.Diagnostics;
using Mchnry.Flow.Work.Define;

namespace Mchnry.Flow.Work
{



    public class WorkflowEngine : IWorkflowEngine
    {
        private readonly Workflow workflow;
        private readonly IActionFactory actionFactory;
        private readonly Logic.IRuleEvaluatorFactory ruleEvaluatorFactory;

        internal Dictionary<string, IAction> Actions { get; set; }

        internal EngineStepTracer processTracer;

        public WorkflowEngine(Define.Workflow workflow, IActionFactory actionFactory, Logic.IRuleEvaluatorFactory ruleEvaluatorFactory)
        {
            this.workflow = workflow;
            this.actionFactory = actionFactory;
            this.ruleEvaluatorFactory = ruleEvaluatorFactory;



        }


        public StepTraceNode<ActivityProcess> Process {
            get {
                //only return if engine started
                throw new NotImplementedException();
            }
        }

        StepTraceNode<ActivityProcess> IWorkflowEngine.CurrentProcess => this.processTracer.CurrentStep;

        IActionFactory IWorkflowEngine.ActionFactory => throw new NotImplementedException();

        

        void IWorkflowEngine.Defer(IAction action, bool onlyIfValidationsResolved)
        {
            throw new NotImplementedException();
        }

        T IWorkflowEngine.GetStateObject<T>(ActivityProcess currentProcess, string key)
        {
            throw new NotImplementedException();
        }

        public T GetStateObject<T>(string key)
        {
            throw new NotImplementedException();
        }

        //void IWorkflowEngine.Inject(Activity activityDefinition, object model)
        //{
        //    throw new NotImplementedException();
        //}

        void IWorkflowEngine.SetStateObject<T>(ActivityProcess currentProcess, string key, T toSave)
        {
            throw new NotImplementedException();
        }

        public void SetStateObject<T>(string key, T toSave)
        {
            throw new NotImplementedException();
        }
    }
}
