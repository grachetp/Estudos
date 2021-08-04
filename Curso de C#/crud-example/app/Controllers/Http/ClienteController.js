'use strict'

const Cliente = use("App/Models/Cliente")

class ClienteController {
  
  //Método de exibir todos
  async index ({ request, response, view }) {
    const clientes = await Cliente.all()
    return clientes
  }

  //Método de criar
  async store ({ request, response }) {
    const data = request.only(["nome", "email"])
    const cliente = await Cliente.create(data)
    
    return cliente;
  }

  //Buscar determinado
  async show ({ params, request, response, view }) {
    const cliente = await Cliente.findOrFail(params.id)
    
    return cliente
  }
  
  //Atualizar
  async update ({ params, request, response }) {
    const cliente = await Cliente.findOrFail(params.id)
    const data = request.only(["nome", "e-mail"])

    cliente.merge(data)
    await cliente.save()
    
    return cliente
  }
  //Excluir
  async destroy ({ params, request, response }) { 
    const cliente = await Cliente.findOrFail(params.id)
    await cliente.delete()
  }
}

module.exports = ClienteController
