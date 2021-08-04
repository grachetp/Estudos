'use strict'

/** @type {typeof import('@adonisjs/framework/src/Route/Manager')} */
const Route = use('Route')

Route.resource("clientes", "ClienteController").apiOnly()



/*
Route.get('/', () => {
  return { greeting: 'Hello world in JSON' }
}) 
*/
