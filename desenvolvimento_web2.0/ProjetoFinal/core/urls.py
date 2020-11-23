from django.urls import path, include
from .views import (
    home,
    lista_pessoas,
    lista_veiculos,
    lista_mov_rotativo,
    lista_mensalista,
    lista_mov_mensalista,
    criar_pessoa,
    criar_veiculo,
    criar_movrot,
    criar_mov_mensalista,
    criar_mensalista,
    update_pessoa,
    update_veiculo,
    update_movrot,
    update_mensalista,
    update_mov_mensalista,
    delete_pessoa,
    delete_veiculo,
    delete_movrot,
    delete_mensalista,
    delete_mov_mensalista,
)

urlpatterns = [
    path('', home, name='core_home'),

    path('pessoas/', lista_pessoas, name='core_lista_pessoas'),
    path('pessoas-criar/', criar_pessoa, name='core_criar_pessoas'),
    path('pessoa-update/<int:id>', update_pessoa, name='core_update_pessoas'),
    path('pessoa-delete/<int:id>', delete_pessoa, name='core_delete_pessoas'),

    path('veiculos/', lista_veiculos, name='core_lista_veiculos'),
    path('veiculos-criar', criar_veiculo, name='core_criar_veiculos'),
    path('veiculos-update/<int:id>', update_veiculo, name='core_update_veiculos'),
    path('veiculos-delete/<int:id>', delete_veiculo, name='core_delete_veiculos'),
    
    path('mov-rots/', lista_mov_rotativo, name='core_lista_mov_rotativo'),
    path('mov-rots-criar', criar_movrot, name='core_criar_mov_rotativo'),
    path('mov-rots-update/<int:id>', update_movrot, name='core_update_mov_rotativo'),
    path('mov-rots-delete/<int:id>', delete_movrot, name='core_delete_mov_rotativo'),

    path('mensalistas/', lista_mensalista, name='core_lista_mensalista'),
    path('mensalistas-criar/', criar_mensalista, name='core_cria_mensalista'),
    path('mensalista-update/<int:id>', update_mensalista, name='core_update_mensalista'),
    path('mensalista-delete/<int:id>', delete_mensalista, name='core_delete_mensalista'),
    
    path('mov-mensalistas/', lista_mov_mensalista, name='core_lista_mov_mensalista'),
    path('mov-mensalistas-criar/', criar_mov_mensalista, name='core_cria_mov-mensalista'),
    path('mov-mensalistas-update/<int:id>', update_mov_mensalista, name='core_update_mov-mensalista'),
    path('mov-mensalistas-delete/<int:id>', delete_mov_mensalista, name='core_delete_mov-mensalista'),
]