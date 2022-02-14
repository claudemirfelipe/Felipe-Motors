using System.Collections.Generic;
using FelipeMotors.Business.Notificacoes;

namespace FelipeMotors.Business.Intefaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}