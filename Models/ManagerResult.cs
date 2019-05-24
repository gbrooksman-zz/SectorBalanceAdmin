using System;


namespace SectorBalQuoteTool.ModelsanceShared
{
    public class ManagerResult<T>
    {
        public ManagerResult()
        {

        }

        public bool Success { get; set; } = true;

        public string Message { get; set; }

        public Exception Exception { get; set; }

        public T Entity { get; set; }

    }
}