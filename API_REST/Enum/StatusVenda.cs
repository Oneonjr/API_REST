using System.ComponentModel;

namespace API_REST.Enum
{
    public enum StatusVenda
    {   [Description("Aguardando pagamento")]
        Aguardando_pagamento = 1,
        [Description("Pagamento aprovado")]
        Pagamento_aprovado = 2,
        [Description("Enviado para transportadora")]
        Enviado_transportadora = 3,
        [Description("Entregue")]
        Entregue = 4,
        [Description("Cancelada")]
        Cancelada = 5
    }
}