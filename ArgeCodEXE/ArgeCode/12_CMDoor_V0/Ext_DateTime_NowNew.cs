﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    /// <summary> https://metanit.com/sharp/tutorial/19.2.php </summary>
    public static class Ext_DateTime_NowNew
    {
        /// <summary>Локальное прошлое вызванное дата время. Используется только в этом контексте.</summary>
        public static System.DateTime p_LocalLastDateTime = System.DateTime.Now;
        /// <summary>Возвращает неповторяющееся датавремя по отношению к прошлому вызванному. А потому может использоваться как Guid.</summary>
        /// <param name="_this">Экземпляр дата время от которого отталкиваемся при использовании этоф функции</param>
        /// <returns>Неповторяющееся по отношению к предыдущему вызванному дата время</returns>
        public static System.DateTime NowNew(this System.DateTime _this)
        {
            while (_this == p_LocalLastDateTime) _this = System.DateTime.Now;
            p_LocalLastDateTime = _this; return _this;
        }
        //////////////////////////////////////////////////////
        [System.Diagnostics.TestLastMethod(_year: 2020, _month: 10, _day: 07, _hour: 11, _minute: 35, _second: 0, _millisecond: 1, _StrComment: "Тест Вывода даты времени в определенном формате")]
        public static bool Test()
        {
            System.Diagnostics.StackTracer.Get_STS().WriteLine();
            for (int i = 0; i < 100; i++)
                System.DateTime.Now.NowNew().ToString("yyyyMMdd_hhmmss_ffff-").WriteLine()
            ;
            return true;
        }
    }
}