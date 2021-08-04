from django.contrib import admin
from .models import (
    Marca,
    Pessoa,
    Veiculo,
    Bairro,
    Endereco,
    Parametros,
    MovRotativo,
    Mensalista,
    MovMensalista,
)


class MovRotativoAdmin(admin.ModelAdmin):
    list_display = (
        'veiculo', 'checkin', 'checkout', 'valor_hora', 'pago', 'total', 'horas_total')


class MovMensalistaAdmin(admin.ModelAdmin):
    list_display = ('mensalista', 'data_pagamento', 'total')


admin.site.register(Marca)
admin.site.register(Pessoa)
admin.site.register(Veiculo)
admin.site.register(Bairro)
admin.site.register(Endereco)
admin.site.register(Parametros)
admin.site.register(MovRotativo, MovRotativoAdmin)
admin.site.register(Mensalista)
admin.site.register(MovMensalista, MovMensalistaAdmin)