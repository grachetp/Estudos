from django.shortcuts import render
from django.http import HttpResponse

# Create your views here.


def clientes(request):
    return HttpResponse('Maria, José, João')


def clientes_por_id(request, id):
    return HttpResponse(id)


def clientes_por_nome(request, nome):
    return HttpResponse('Olá {}, tudo bem?'.format(nome))