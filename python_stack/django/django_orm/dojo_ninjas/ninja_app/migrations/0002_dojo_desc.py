# Generated by Django 2.2.7 on 2019-11-07 22:53

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('ninja_app', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='dojo',
            name='desc',
            field=models.TextField(default='old dojo'),
            preserve_default=False,
        ),
    ]
