using ApiAudaces.Context;
using ApiAudaces.Models;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAudaces.GraphQL
{
    public class Mutation
    {
        public async Task<List<int>> Calculate([Service] DatabaseContext context, ApiInput input)
        {
            var foundSequence = new List<int>();
            var target = input.Target;
            var sequence = string.Concat("[", String.Join(", ", input.Sequence.ToArray()), "]");
            var orderedSequence = new List<int>();

            if (target > 0)
                orderedSequence = input.Sequence.OrderByDescending(x => x).Where(x => x > 0).ToList();
            else if (target < 0)
                orderedSequence = input.Sequence.OrderBy(x => x).Where(x => x < 0).ToList();

            foreach (var num in orderedSequence)
            {
                var numX = Math.Truncate(Convert.ToDouble(target / num));
                if (numX != 0)
                {
                    for (var i = 0; i < numX; i++)
                    {
                        target -= num;
                        foundSequence.Add(num);
                    }
                }
            }

            if (target != 0)
                foundSequence.Clear();


            var apiInput = new ApiModel()
            {
                Sequence = sequence,
                Target = input.Target,
                Date = DateTime.Today,
                FoundSequence = string.Concat("[", String.Join(", ", foundSequence.ToArray()), "]")
            };

            context.Calls.Add(apiInput);
            await context.SaveChangesAsync();

            return foundSequence;
        }
    }
}
