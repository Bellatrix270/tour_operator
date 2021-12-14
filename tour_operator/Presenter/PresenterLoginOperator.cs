using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tour_operator.Model;
using tour_operator.View;

namespace tour_operator.Presenter
{
    public class PresenterLoginOperator : IPresenter
    {
        ModelDB modelDB = new ModelDB();
        ILoginOperator operatorView;

        public PresenterLoginOperator(ILoginOperator operatorView)
        {
            this.operatorView = operatorView;
        }

        public void isExistOperator()
        {
            operatorView.IsExistOperator = modelDB.IsExistOperator(operatorView.EmailOperator, operatorView.PasswordOperator);
        }

        public void Run()
        {
            operatorView.Show();
        }
    }
}
