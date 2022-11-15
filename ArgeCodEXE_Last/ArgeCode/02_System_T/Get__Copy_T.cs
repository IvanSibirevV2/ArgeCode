namespace System
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    ////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////
    public static class Get__Copy_T
    {
        /// <summary>
        /// Инструмент глубокого рефлексивного копирования.
        /// Область применимости: базовые типы данных; Наследники интерфейса INewEable или ICloneable; классы с беспараметрическим конструктором; классы без циклических ссылок;
        /// </summary>
        public static T Get__Copy<T>(this T _this)
        {
            if (_this == null){throw new System.Exception("Eror: _this == null   !!!");return _this;}
            if (_this is ICloneable _ICloneable) return (T)_ICloneable.Clone();
            
            System.Type _Type = _this.GetType();
            {//Проверяем является ли объект базовым объектом и ищем//в специализированном списке обработчик Объекта
             //По идее этот бред способен делать <<глубокие>> копии базовых (простых объектов) типо строк или чисел.
                //Двухкратная обертак базовых типов приводит к глубокому копированию, как не странно. Я проверял
                //!!Если будете добовлять своё что-то новое, то проверяйте на предмет глубокого копирования
                //В С# есть принцип://_this.ToString==_this.GetType().FullName =>
                //этот класс сложный (то биш Типа public class), иначе он простой(базовый или .Net овский).
                //Но проверка по нему не бывает надёжной так как многие программисты переопределяют .ToString по своему усмотрению
                //Поэтому их проверять нужно по отдельности//Такая типо скриптовая реализация проще чем списки и иерархии объектов...
                //Это в разы лучше чем тратить на это +100500 классов инспекторов обработчиков и прочей ериси...
                //Не спеши судить, Этот кусок красивое следствие рефакторинга и "бритвы Уильяма Оккама"
                if (_Type == typeof(System.Boolean)) return (T)(System.Object)(((System.Boolean)(System.Object)_this) ? true : false);
                if (_Type == typeof(System.Byte)) return (T)(System.Object)((System.Byte)(System.Object)_this);
                if (_Type == typeof(System.Char)) return (T)(System.Object)((System.Char)(System.Object)_this);
                if (_Type == typeof(System.Decimal)) return (T)(System.Object)((System.Decimal)(System.Object)_this);
                if (_Type == typeof(System.Double)) return (T)(System.Object)((System.Double)(System.Object)_this);
                if (_Type == typeof(System.Int16)) return (T)(System.Object)((System.Int16)(System.Object)_this);
                if (_Type == typeof(System.Int32)) return (T)(System.Object)((System.Int32)(System.Object)_this);
                if (_Type == typeof(System.Int64)) return (T)(System.Object)((System.Int64)(System.Object)_this);
                if (_Type == typeof(System.SByte)) return (T)(System.Object)((System.SByte)(System.Object)_this);
                if (_Type == typeof(System.Single)) return (T)(System.Object)((System.Single)(System.Object)_this);
                if (_Type == typeof(System.String)) return (T)(System.Object)((System.String)(System.Object)_this+"");
                if (_Type == typeof(System.UInt16)) return (T)(System.Object)((System.UInt16)(System.Object)_this);
                if (_Type == typeof(System.UInt32)) return (T)(System.Object)((System.UInt32)(System.Object)_this);
                if (_Type == typeof(System.UInt64)) return (T)(System.Object)((System.UInt64)(System.Object)_this);
                ///////////////////////////////////////////////////////////////////////////////////////////////////
            }
            if (_Type.IsArray)//Проверяем на массив
            {//Копируем любой массив
                //Я в шоке. Многократное обертывание
                //Лучше если реализовать для объекта ICopyEable<T> 
                System.Array _Array_A = ((System.Array)((System.Object)_this));
                int _Length = _Array_A.Length;
                System.Array _Array_B = System.Array.CreateInstance(_Array_A.GetType(), _Length);
                for (int i = 0; i < _Length; i++)
                    _Array_B.SetValue(_Array_A.GetValue(i).Get__Copy(), i);
                return (T)((System.Object)_Array_B);
            }
            else if (_Type.Get_IsList())//Проверяем авдруг это список...
            {
                System.Collections.IList _IList_A = (System.Collections.IList)((System.Object)_this);
                int _Count = _IList_A.Count;
                System.Collections.IList _IList_B = (System.Collections.IList) Activator.CreateInstance(_Type);
                foreach (object _Value in _IList_A)
                    _IList_B.Add(_Value.Get__Copy());
                return (T)((System.Object)_IList_B);
            }
            ////Жёсткое создание нового экземпляра
            T _t;
            //через рефлексию проверяем есть ли у объекта безпараметрический открытый конструктор
            //и возвращаем его через активатор
            //Проверить проще через finally{}try{}catch{}finally{}
            try { _t = (T)Activator.CreateInstance(_this.GetType()); }
            catch (System.Exception e)
            {
                System.Console.WriteLine(_Type.ToString());//Если базового конструктора нет , то 
                throw new System.Exception("Eror: Get__New<T==" + _Type.ToString() + ">-NotExpect!!!");
            }
            //Копируем и вставляем вообще все поля.
            _Type.GetFields(System.Diagnostics.Reflection.Const.p_MyBindingFlags).ToList()
                .ForEach(_field => _field.SetValue(_t, _field.GetValue(_this).Get__Copy()))
            ;
            //Дело в том что это Свойства калсса которые {Get;Set;}
            //Хорошим стилем считается когда есть и поле и свойство, свойство класса тунельно принимает и возвращает значение
            //Плохим стилем считается наложение логики на {Get;Set;} свойства классов//Подозреваю этот гемор идет из делфи
            //Чтобы не крыть матом лишний раз Макрософаг глубокое копирование осуществляем только для полей, 
            //Вообще для всех, приватных и открытых.....
            if (false)
            _Type.GetProperties( System.Diagnostics.Reflection.Const.p_MyBindingFlags).ToList()
                .ForEach(
                    _prop=> _prop.SetIf(_prop.CanWrite && _prop.CanRead,a=> _prop.SetValue(_t,_prop.GetValue(_this).Get__Copy()))
                )
            ;
            //На этом данный квест считаю выполненым
            //Опосля возможно написание модульных тестов...
            return _t;
            ////низя аттата
            ////Мягкое создание нового экземпляра
            //return _this;
        }
        /// <summary> Проверка, является ли объект списком </summary>/// <param name="_Type">Анализируемый тип</param>
        public static System.Boolean Get_IsList(this System.Type _Type) => (_Type.Namespace + "." + _Type.Name).Get(b => b.Remove(b.Length - 2)) == "System.Collections.Generic.List";
    }
}
