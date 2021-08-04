from django.contrib import admin
from .models import Empregado, Telefone, CPF, Departamento

# Register your models here.

class EmpregadoAdmin(admin.ModelAdmin):
    #fields = ('nome', 'endereco')
    list_display = ('id', 'nome', 'endereco', 'email')
    list_filter = ('departamentos', )
    search_fields = ('nome', 'id')

admin.site.register(Empregado, EmpregadoAdmin)
admin.site.register(Telefone)
admin.site.register(CPF)
admin.site.register(Departamento)
