namespace Component.Reflection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    //////////////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////////
    /// <summary>Просто пример</summary>
    public static class Query
    {
        /// <summary> Линейный запрос списка типов классов программы без фильтра </summary>
        public static List<System.Type> GetTypeS() =>(new List<System.Type>())
            .Set(_TypeS =>
                AppDomain.CurrentDomain.GetAssemblies().ToList().ForEach(_AssemblieS =>
                    _AssemblieS.GetTypes().ToList().ForEach(_Type => _TypeS.Add(_Type))
                )
            )
        ;
        /// <summary> Линейный запрос списка типов классов программы с оптимальным по объему в памяти и быстродействию фильтром</summary>
        public static List<System.Type> GetTypeS(Func<System.Type, bool> _predicate) => (new List<System.Type>())
            .Set(_TypeS =>
                AppDomain.CurrentDomain.GetAssemblies().ToList().ForEach(_AssemblieS =>
                    _AssemblieS.GetTypes().Where(a => _predicate(a)).ToList().ForEach(_Type => _TypeS.Add(_Type))
                )
            )
        ;
    }
}