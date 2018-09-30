using DesigningTestableApplications.Tip5.Service;

namespace DesigningTestableApplications.Tip5.UI
{
    public class Presentation
    {
        private readonly IService service;

        public Presentation(IService service)
        {
            this.service = service;
        }

        public ResultModel UIMethod(int param1, string param2)
        {
            //Method code...
            
            //Calls service
            Result result = this.service.Method(param1, param2);

            //Method code...
            var numberText = string.Format("Number: {0} - Text: {1}", result.Number, result.Text);

            //Returns the result
            return new ResultModel { NumberText = numberText, IsOk = result.IsOk };
        }
    }
}
