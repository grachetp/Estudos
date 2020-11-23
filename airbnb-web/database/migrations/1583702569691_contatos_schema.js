'use strict'

/** @type {import('@adonisjs/lucid/src/Schema')} */
const Schema = use('Schema')

class ContatosSchema extends Schema {
  up () {
    this.create('contatos', (table) => {
      table.increments()
      table.string('nome', 80).notNullable()
      table.string('telefone', 12).notNullable().unique()
      table.timestamps()
    })
  }

  down () {
    this.drop('contatos')
  }
}

module.exports = ContatosSchema
