'use strict'

const Contato = use("App/Models/Contato")

class ContatoController {
  async index ({ request, response, view }) {
    const contatos = await Contato.all()
    return contatos
  }

  async store ({ request, response }) {
    const data = request.only(["nome","telefone"])
    const contato = await Contato.create(data)
    return contato
  }

  async show ({ params, request, response, }) {
    const contato = await Contato.findOrFail(params.id)
    return contato
  }
  async update ({ params, request, response }) {
    const contato = await Contato.findOrFail(params.id)
    const data = request.only(["nome", "telefone"])
    contato.merge(data)
    await contato.save()
    return contato
  }
  async destroy ({ params, request, response }) {
    const contato = await Contato.findOrFail(params.id)
    await contato.delete()
  }
}

module.exports = ContatoController
