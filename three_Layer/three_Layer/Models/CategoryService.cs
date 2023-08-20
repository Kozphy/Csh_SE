using three_Layer.Models.Daos;
using three_Layer.Models.Dtos;

namespace three_Layer.Models
{
    public class CategoryService
    {
        private readonly CategoryDao dao = new CategoryDao();

        public void Create(CategoryDto dto)
        {

            #region business logic check
            // check name whether exists in database
            if (dao.GetbyName(dto.CategoryName) != null)
            {
                throw new Exception("CategoryName already exist.");
            }

            #endregion

            // create Category data
            dao.Create(dto);
        }
    }
}
