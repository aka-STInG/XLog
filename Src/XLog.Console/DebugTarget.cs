﻿using System;

namespace XLog.ConsoleApp
{
    public class DebugTarget : Target
    {
        public DebugTarget(IFormatter formatter = null)
            : base(formatter)
        {
        }

        public override void Write(string content)
        {
            System.Diagnostics.Debug.WriteLine(content);
        }
    }
}
