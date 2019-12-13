using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace TicketSystemApp_P113.Core
{
  public static class FormExtensions
    {
        public static void ExtendHeightTo(this Form form,int size)
        {
            form.Size = new Size(form.Size.Width, size);
        }
        public static T AddUserControlToForm<T>(this Form form,string controlTag) where T : Control
        {
            T control = Activator.CreateInstance<T>();
            control.Tag = controlTag;
            control.Location = new Point(60, 60);
            form.Controls.Add(control);
            return control;
        }
        public static T FindControl<T>(this Form form,Func<T, bool> predicate) where T : Control
        {
            return form.Controls
                         .OfType<T>()
                              .Where(predicate)
                                    .FirstOrDefault();
        }
        public static T MapDataToModel<T>(this Form form,string withPrefix)
        {
             var typeProperties = typeof(T).GetProperties();
            var allTextBoxes = GetAllTextBoxes(form.Controls);
             T obj = Activator.CreateInstance<T>();
            foreach (var item in typeProperties)
            {
                string propertyValue = allTextBoxes.Where(x => x.Name == $"{withPrefix}{item.Name}").FirstOrDefault()?.Text;
                item.SetValue(obj, propertyValue);
            }
            return obj;
        }

        private static List<TextBox> GetAllTextBoxes(ControlCollection controls)
        {
            List<TextBox> boxes = new List<TextBox>();
            foreach (Control control in controls)
            {
                boxes = control.Controls.OfType<TextBox>().ToList();
                if (boxes.Count == 0)
                   boxes = GetAllTextBoxes(control.Controls);
            }
            return boxes;
            
        }
     

        public static void DisplayErrors(this Form form,IEnumerable<ValidationResult> validationResults,Control applyTo)
        {
            applyTo.Text = "";
            foreach (var item in validationResults)
            {
                applyTo.Text += item.ErrorMessage + "\n";
            }
        }

        public static void RedirectTo<T>(this Form form) where T:Form
        {
           T createdForm = Activator.CreateInstance<T>();
            form.Hide();
            createdForm.ShowDialog();
        }

        public static void RedirectTo(this Form form,Form toForm)
        {
            form.Close();
            toForm.Show();
        }

        public static bool IsValid(this Form form,object objectToValidate, Control errorsOn)
        {
            EntityValidator entityValidator = new EntityValidator();
            errorsOn.Text = "";
            IEnumerable<ValidationResult> validationResults = entityValidator.Validate(objectToValidate);

            //if has error..
            if (validationResults != null)
            {
                DisplayErrors(form, validationResults, errorsOn);
                return false;
            }
            else
                return true;
        }
    }
}
