using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webschool.Data;
using webschool.Models;

namespace webschool.Helpers
{
    public class ComboField : IDisposable
    {
        private static webschoolContext db = new webschoolContext();

        public static List<Field> GetFields()
        {
            var fields = db.Fields.ToList();
            fields.Add(new Field
            {
                FieldID = 0,
                Description = "[Selecionar uma área]"
            });

            return fields.OrderBy(d => d.Description).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}