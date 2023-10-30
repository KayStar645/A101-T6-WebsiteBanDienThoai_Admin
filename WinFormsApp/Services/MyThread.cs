namespace WinFormsApp.Services
{
    public class MyThread
    {
        Thread? thread;

        public void CloseThisOpenThat(Form pOldForm, Form pNewForm)
        {
            pOldForm.Close();
            thread = new Thread(() =>
            {
                Application.Run(pNewForm);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
