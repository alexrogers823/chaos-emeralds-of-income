// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace ChaosEmeraldsOfIncome.Controllers
// {
//     public class SqlEarnedIncomeRepo : IEarnedIncomeRepo
//     {
//         private readonly CEOIContext _context;

//         public SqlEarnedIncomeRepo(CEOIContext context)
//         {
//             _context = context;
//         }
//         public IEnumerable<EarnedIncome> GetEarnedIncome()
//         {
//             return _context.EarnedIncome.ToList();
//         }

//         // change this to void 
//         public IEnumerable<EarnedIncome> InsertEarnedIncome(EarnedIncome income)
//         {
//             if (income == null)
//             {
//                 throw new ArgumentNullException(nameof(income));
//             }

//             _context.EarnedIncome.Add(income);

//         }
//     }
// }