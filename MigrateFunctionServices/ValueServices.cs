using System.Threading.Tasks;

namespace MigrateFunctionServices
{
    public class ValueServices
    {
        public async Task<string[]> GetValues()
        {
            var result = new string[] {"value1", "value2"};
            return await Task.FromResult(result);
        }

        public async Task<bool> UpdateValues()
        {
            return await Task.FromResult(true);
        }
    }
}
