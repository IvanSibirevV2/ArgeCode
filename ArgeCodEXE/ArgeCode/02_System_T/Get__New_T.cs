namespace System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    ////////////////////////////////////////////////////////////////
    public static class Get__New_T
    {
        //public static System.Object Get_CreateInstance(this System.Type _this)=> System.Activator.CreateInstance(_this, true);
        /// <summary>
        /// Метод получения нового экземпляра класса.
        /// Область действия: базовые типы данных; Наследники интерфейса INewEable; классы с беспараметрическим конструктором;
        /// </summary>
        public static T Get__New<T>(this T _this)
        {
            if (_this is INewEable _INewEable_T) return (T)_INewEable_T.New();
            System.Type _Type = _this.GetType();
            {//Это в разы лучше чем тратить на это +100500 классов инспекторов обработчиков и прочей ериси...
                //Не спеши судить, Этот кусок красивое следствие рефакторинга и "бритвы Уильяма Оккама"
                if (_Type == typeof(System.Boolean)) return (T)(System.Object)(new System.Boolean());
                if (_Type == typeof(System.Byte)) return (T)(System.Object)(new System.Byte());
                if (_Type == typeof(System.Char)) return (T)(System.Object)(new System.Char());
                if (_Type == typeof(System.Decimal)) return (T)(System.Object)(new System.Decimal());
                if (_Type == typeof(System.Double)) return (T)(System.Object)(new System.Double());
                if (_Type == typeof(System.Int16)) return (T)(System.Object)(new System.Int16());
                if (_Type == typeof(System.Int32)) return (T)(System.Object)(new System.Int32());
                if (_Type == typeof(System.Int64)) return (T)(System.Object)(new System.Int64());
                if (_Type == typeof(System.SByte)) return (T)(System.Object)(new System.SByte());
                if (_Type == typeof(System.Single)) return (T)(System.Object)(new System.Single());
                if (_Type == typeof(System.String)) return (T)(System.Object)("");
                if (_Type == typeof(System.UInt16)) return (T)(System.Object)(new System.UInt16());
                if (_Type == typeof(System.UInt32)) return (T)(System.Object)(new System.UInt32());
                if (_Type == typeof(System.UInt64)) return (T)(System.Object)(new System.UInt64());
            }
            T _t;
            try { _t = (T)Activator.CreateInstance(_this.GetType(),true);}
            catch (System.Exception e)
            {
                System.Console.WriteLine(_Type.ToString());
                throw new System.Exception("Eror: Get__New<T==" + _Type.ToString() + ">-NotExpect!!!");
            }
            return _t;
        }
    }
}