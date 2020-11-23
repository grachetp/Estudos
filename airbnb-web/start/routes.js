'use strict'

/** @type {typeof import('@adonisjs/framework/src/Route/Manager')} */
const Route = use('Route')

//Rota de Requisições
Route.resource("contatos", "ContatoController").apiOnly()