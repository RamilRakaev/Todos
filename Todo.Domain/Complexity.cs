using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todos.Domain
{
    public enum Complexity
    {
        /// <summary>
        /// До часа
        /// </summary>
        Level_1 = 1,

        /// <summary>
        /// 1-5 часов
        /// </summary>
        Level_2 = 5,

        /// <summary>
        /// До одного дня
        /// </summary>
        Level_3 = 24,

        /// <summary>
        /// не больше 5 дней
        /// </summary>
        Level_4 = 120,

        /// <summary>
        /// до одного месяца
        /// </summary>
        Level_5 = 672,

        /// <summary>
        /// 1-2 месяцев
        /// </summary>
        Level_6 = 1460,

        /// <summary>
        /// не больше года
        /// </summary>
        Level_7 = 8760,
    }
}
