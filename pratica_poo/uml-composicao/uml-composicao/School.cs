﻿using System;
using System.Collections.Generic;

namespace uml_composicao
{
    public class School : IDisposable
    {
        public string Name { get; set; }

        private List<Department> departments = new List<Department>();

        public void AddDepartment(string name)
        {
            departments.Add(new Department(this, name));
        }

        public void Dispose()
        {
            foreach (var department in departments)
            {
                department.Dispose();
            }
        }
    }
}
