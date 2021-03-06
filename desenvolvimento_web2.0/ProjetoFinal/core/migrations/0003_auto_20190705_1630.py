# Generated by Django 2.2.3 on 2019-07-05 19:30

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('core', '0002_veiculo_proprietario'),
    ]

    operations = [
        migrations.CreateModel(
            name='Bairro',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('nome', models.CharField(max_length=50)),
            ],
        ),
        migrations.CreateModel(
            name='Endereco',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('rua', models.CharField(max_length=50)),
                ('numero', models.PositiveIntegerField()),
                ('bairro', models.ForeignKey(on_delete=django.db.models.deletion.PROTECT, to='core.Bairro')),
            ],
        ),
        migrations.AlterField(
            model_name='pessoa',
            name='endereco',
            field=models.ForeignKey(on_delete=django.db.models.deletion.PROTECT, to='core.Endereco'),
        ),
    ]
