using System.ComponentModel;
using thelibrary.Helpers;

namespace thelibrary.Data.enums
{
    public enum Permission
    {
        //ADMIN MANAGEMENT
        [Category(RoleHelper.ADMIN), Description("Access to Create Book")]
        ADD_BOOK_MANAGEMENT = 1001,
        [Category(RoleHelper.ADMIN), Description("Access to Edit Book")]
        EDIT_BOOK_MANAGEMENT = 1002,
        [Category(RoleHelper.ADMIN), Description("Access to Delete Book")]
        DELETE_BOOK_MANAGEMENT = 1003,
        [Category(RoleHelper.ADMIN), Description("Access to Borrow History")]
        BORROW_BOOK_MANAGEMENT = 1004,
        //[Category(RoleHelper.ADMIN), Description("Access to Add Recommendation")]
        //RECOMMENDATION_MANAGEMENT = 1005,


        //ADMIN STUDENT MANAGEMENT
        [Category(RoleHelper.ADMIN), Description("Access to Delete Student Account")]
        STUDENT_PAGE = 1020,
        [Category(RoleHelper.ADMIN), Description("Access to Register Student")]
        STUDENT_ADD_NEW = 1021,
        [Category(RoleHelper.ADMIN), Description("Access to Create Category")]
        STUDENT_ADD_TO_BATCH = 1022,
        [Category(RoleHelper.ADMIN), Description("Access to Edit Ctegory")]
        STUDENT_EDIT = 1023,
        [Category(RoleHelper.ADMIN), Description("Access to delete category")]
        STUDENT_DEACTIVATE = 1024,
        [Category(RoleHelper.ADMIN), Description("Access to View Student Details")]
        STUDENT_VIEW_DETAILS = 1025,
        //[Category(RoleHelper.ADMIN), Description("Access to Batch page")]

    }
}
