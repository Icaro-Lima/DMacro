using System.Collections.Generic;

namespace DMacro
{
    interface IEvent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="variables"></param>
        /// <returns>A linha para ir ou -1 se for para ir para a próxima linha.</returns>
        int Run(Dictionary<string, object> variables);
    }
}
