'use strict'

/** @type {typeof import('@adonisjs/framework/src/Route/Manager')} */
const Route = use('Route')

Route.post('/users', 'UserController.create');
Route.post('/sessions', 'SessionController.create')

//Nesse caso estamos informando para o Adonis criar todas as rotas de listagem,
//exibição, criação, edição e remoção de imóveis em um único comando. 
//O método apiOnly() garante as rotas create e edit que deletamos anteriormente 
//não tenham rota, já o middlewareauth vai garantir que usuários não autenticados
//não possam utilizar essas rotas.
Route.resource('properties', 'PropertyController')
  .apiOnly()
  .middleware('auth')

Route.post('properties/:id/images', 'ImageController.store')
  .middleware('auth')

Route.get('images/:path', 'ImageController.show')

