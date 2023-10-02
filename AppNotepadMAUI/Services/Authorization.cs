using AppNotepadMAUI.Model;
using BL_MAUI;

namespace AppNotepadMAUI.Services
{
    internal class Authorization
    {
        public Model.User  GetUser (string login , string password)
        {
            try
            {
                AuthorizationService service = new AuthorizationService (); 
                var r =   service.GetUser (login, password);
                return new Model.User { Id = r.Id, UserName = r.UserName };
            }
            catch (Exception ex )
            {
                throw new NotImplementedException(ex.Message);
            }
        }
    }
}
