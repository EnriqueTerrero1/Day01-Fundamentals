using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class CRUD <T>
    {
        List<T> Entity = new List<T>();


        public void Add(T entity)

        {
            Entity.Add(entity);

        }
        public List<T> Getall()
        {
            return (Entity);
        }

        public void Remove(int index) {   
            
            Entity.RemoveAt(index-1); 
        }
        public void Update(T entity,int index) {

            Entity[index - 1] = entity; 

         
        
        }

        

    }
}
