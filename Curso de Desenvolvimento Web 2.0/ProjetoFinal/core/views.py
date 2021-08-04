from django.shortcuts import render, redirect
from django.contrib.auth.decorators import login_required

from .models import (
    Pessoa,
    Veiculo,
    MovRotativo, 
    Mensalista, 
    MovMensalista
)
from .forms import (
    PessoaForm, 
    VeiculoForm, 
    MovRotativoForm,
    MensalistaForm,
    MovRotativoForm,
    MovMensalistaForm
)


def home(request):
    context = {'mensagem': 'Bem vindo a tela inicial'}
    return render(request, 'core/index.html', context)


#Pessoas#
@login_required
def lista_pessoas(request):
    pessoas = Pessoa.objects.all()
    form = PessoaForm()
    data = {'pessoas': pessoas, 'form': form}
    return render(request, 'core/lista_pessoas.html', data)

@login_required
def criar_pessoa(request):
    form = PessoaForm(request.POST or None)
    if form.is_valid():
        form.save()
    return redirect('core_lista_pessoas')

@login_required
def update_pessoa(request, id):
    data = {}
    pessoa = Pessoa.objects.get(id=id)
    form = PessoaForm(request.POST or None, instance=pessoa)
    data['pessoa'] = pessoa
    data['form'] = form

    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('core_lista_pessoas')
    else:
        return render(request, 'core/update_pessoas.html', data)

@login_required
def delete_pessoa(request, id):
    pessoa = Pessoa.objects.get(id=id)
    if request.method == 'POST':
        pessoa.delete()
        return redirect('core_lista_pessoas')
    else:
        return render(request, 'core/delete_confirm.html', {'obj': pessoa})


#Veiculos
@login_required
def lista_veiculos(request):
    veiculos = Veiculo.objects.all()
    form = VeiculoForm()
    data = {'veiculos': veiculos, 'form': form}
    return render(request, 'core/lista_veiculos.html', data)

@login_required
def criar_veiculo(request):
    form = VeiculoForm(request.POST or None)
    if form.is_valid():
        form.save()
    return redirect('core_lista_veiculos')

@login_required
def update_veiculo(request, id):
    data = {}
    veiculo = Veiculo.objects.get(id=id)
    form = VeiculoForm(request.POST or None, instance=veiculo)
    data['veiculo'] = veiculo
    data['form'] = form

    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('core_lista_veiculos')
    else:
        return render(request, 'core/update_veiculo.html', data)

@login_required
def delete_veiculo(request, id):
    veiculo = Veiculo.objects.get(id=id)
    if request.method == 'POST':
        veiculo.delete()
        return redirect('core_lista_veiculos')
    else:
        return render(request, 'core/delete_confirm.html', {'obj': veiculo})

#Movimentos Rotativos
@login_required
def lista_mov_rotativo(request):
    mov_rot = MovRotativo.objects.all()
    form = MovRotativoForm()
    data = {'mov_rot': mov_rot, 'form': form}
    return render(request, 'core/lista_movrotativos.html', data)

@login_required
def criar_movrot(request):
    form = MovRotativoForm(request.POST or None)
    if form.is_valid():
        form.save()
    return redirect('core_lista_mov_rotativo')

@login_required
def update_movrot(request, id):
    data = {}
    mov_rot = MovRotativo.objects.get(id=id)
    form = MovRotativoForm(request.POST or None, instance=mov_rot) 
    data['form'] = form
    data['mov_rot'] = mov_rot

    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('core_lista_mov_rotativo')
    else:
        return render(request, 'core/update_mov_rotativo.html', data)

@login_required
def delete_movrot(request, id):
    mov_rot = MovRotativo.objects.get(id=id)
    if request.method == 'POST':
        mov_rot.delete()
        return redirect('core_lista_mov_rotativo')
    else:
        return render(request, 'core/delete_confirm.html', {'obj': mov_rot})
    

#Mensalistas
@login_required
def lista_mensalista(request):
    form = MensalistaForm()
    mensalistas = Mensalista.objects.all()
    data = {'mensalistas': mensalistas, 'form':form}
    return render(request, 'core/lista_mensalistas.html', data)

@login_required
def criar_mensalista(request):
    form = MensalistaForm(request.POST or None)
    if form.is_valid():
        form.save()
    return redirect('core_lista_mensalista')

@login_required
def update_mensalista(request, id):
    data = {}
    mensalista = Mensalista.objects.get(id=id)
    form = MensalistaForm(request.POST or None, instance=mensalista)
    data['form'] = form
    data['mensalista'] = mensalista

    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('core_lista_mensalista')
    else:
        return render(request, 'core/update_mensalista.html', data)

@login_required
def delete_mensalista(request, id):
    mensalista = Mensalista.objects.get(id=id)
    if request.method == 'POST':
        mensalista.delete()
        return redirect('core_lista_mensalista')
    else:
        return render(request, 'core/delete_confirm.html', {'obj': mensalista})

#Movimento dos mensalistas
@login_required
def lista_mov_mensalista(request):
    mov_mensalistas = MovMensalista.objects.all()
    form = MovMensalistaForm()
    data = {'mov_mensalistas': mov_mensalistas, 'form': form}
    return render(request, 'core/lista_mov_mensalista.html', data)

@login_required
def criar_mov_mensalista(request):
    form = MovMensalistaForm(request.POST or None)
    if form.is_valid():
        form.save()
    return redirect('core_lista_mov_mensalista')

@login_required
def update_mov_mensalista(request, id):
    mov_mensalistas = MovMensalista.objects.get(id=id)
    form = MovMensalistaForm(request.POST or None, instance=mov_mensalistas)
    data = {'form': form, 'mov_mensalistas': mov_mensalistas}

    if request.method == 'POST':
        if form.is_valid():
            form.save()
            return redirect('core_lista_mov_mensalista')
    else:
        return render(request, 'core/update_mov-mensalista.html', data)

@login_required
def delete_mov_mensalista(request, id):
    mov_mensalistas = MovMensalista.objects.get(id=id)
    if request.method == 'POST':
        mov_mensalistas.delete()
        return redirect('core_lista_mov_mensalista')
    else:
        return render(request, 'core/delete_confirm.html', {'obj': mov_mensalistas})