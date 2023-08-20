using System.Drawing.Text;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using three_Layer.Models.Dtos;

// data access layer
namespace three_Layer.Models.Daos
{
    public class CategoryDao
    {
        private readonly northwindsContext? _db = null;

        public CategoryDao()
        {
            _db = new northwindsContext();
        }

        public void Create(CategoryDto dto)
        {
            var category = new Category()
            {
                CategoryName = dto.CategoryName,
                Description = dto.Description,
                Picture = dto.Picture,
                ColumnTest = dto.ColumnTest,
            };

            _db!.Categories.Add(category);
            _db!.SaveChanges();
        }

        public CategoryDto? GetbyName(string name)
        {
            var category = _db!.Categories.FirstOrDefault(x => x.CategoryName == name);

            return (category == null) ? null :
             new CategoryDto
            {
                CategoryName = category.CategoryName,
                Description = category.Description,
                Picture = category.Picture,
                ColumnTest = category.ColumnTest,
            };
        }
    }
}
