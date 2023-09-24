using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelBinderCustom.Models;

namespace ModelBinderCustom.CustomerModelBinders
{
    // when we need to implement Customer ModelBinding
    // we need to add IModelBinder to class 
    public class PersonModelBinder : IModelBinder
    {
        // FirstName and LastName
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            Person person = new Person();
            // get FirstName from ModelBinding
            if (bindingContext.ValueProvider.GetValue("FirstName").Any())
            {
                // FirstValue = [0]
               person.PersonName = bindingContext.ValueProvider.GetValue("FirstName").FirstValue;

               if (bindingContext.ValueProvider.GetValue("LastName").Any())
               {
                   person.PersonName += " " + bindingContext.ValueProvider.GetValue("LastName");
               }
            }
            bindingContext.Result = ModelBindingResult.Success(person);
            return Task.CompletedTask;
        }
    }
}
