"""first_project URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/2.2/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  path('', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  path('', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.urls import include, path
    2. Add a URL to urlpatterns:  path('blog/', include('blog.urls'))
"""
from django.urls import path
from django.conf.urls import url #importing url from django.conf.urls to use parameters with paths
from first_app import views

urlpatterns = [
    path('', views.index),
    path('new', views.new),
    path('create', views.create),
    url(r'^(?P<number>\d+)$', views.show), # added the +, originally it only showed placeholder blogs 0-9
    # path('<int:number>', views.show),
    path('<int:number>/edit', views.edit),
    path('<int:number>/delete', views.destroy),
]