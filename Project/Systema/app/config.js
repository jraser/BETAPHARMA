var configFunction = function ($stateProvider, $urlRouterProvider, $locationProvider, $httpProvider) {

    $locationProvider.hashPrefix('!').html5Mode(true);

 
    $urlRouterProvider.otherwise("/Dashboard");

    $stateProvider


         .state('GrupoList', {
             url: '/GrupoList',
             views: {
                 "containerOne": {
                     templateUrl: "Grupo/List",
                     controller: GrupoController
                 }
             }
         })

          .state('GrupoCreate', {
              url: '/GrupoCreate',
              views: {
                  "containerOne": {
                      templateUrl: "Grupo/Create",
                      controller: GrupoController
                  }
              }
          })
          .state('GrupoEdit', {
              url: '/GrupoEdit',
              views: {
                  "containerOne": {
                      templateUrl: "Grupo/Create",
                      controller: GrupoController
                  }
              }
          })

             .state('ALTProductoBySocioList', {
                 url: '/ALTProductoBySocioList',
                 views: {
                     "containerOne": {
                         templateUrl: "ListaPrecio/List",
                         controller: ListaPrecioController
                     }
                 }
             })



            .state('AlmacenList', {
                url: '/AlmacenList',
                views: {
                    "containerOne": {
                        templateUrl: "Almacen/List",
                        controller: AlmacenController
                    }
                }
            })



         .state('AlmacenCreate', {
             url: '/AlmacenCreate',
             views: {
                 "containerOne": {
                     templateUrl: "Almacen/Create",
                     controller: AlmacenController
                 }
             }
         })


             .state('AlmacenEdit', {
                 url: '/AlmacenEdit',
                 views: {
                     "containerOne": {
                         templateUrl: "Almacen/Create",
                         controller: AlmacenController
                     }
                 }
             })


        .state('RequerimientosList', {
            url: '/RequerimientoList',
            views: {
                "containerOne": {
                    templateUrl: "Requerimientos/List",
                    controller: RequerimientosController
                }
            }
        })
                 .state('RequerimientosCreate', {
                     url: '/RequerimientosCreate',
                     views: {
                         "containerOne": {
                             templateUrl: "Requerimientos/Create",
                             controller: RequerimientosController
                         }
                     }
                 })


           .state('RequerimientosModific', {
               url: '/RequerimientosModific',
               views: {
                   "containerOne": {
                       templateUrl: "Requerimientos/Modific",
                       controller: RequerimientosController
                   }
               }
           })



        .state('SocioNegocioList', {
            url: '/SocioNegocioList',
            views: {
                "containerOne": {
                    templateUrl: "SocioNegocio/List",
                    controller: SocioNegocioController
                }
            }
        })

     .state('SocioNegocioCreate', {
         url: '/SocioNegocioCreate',
         views: {
             "containerOne": {
                 templateUrl: "SocioNegocio/Create",
                 controller: SocioNegocioController
             }
         }
     })
        .state('SocioNegocioEdit', {
            url: '/SocioNegocioEdit',
            views: {
                "containerOne": {
                    templateUrl: "SocioNegocio/Create",
                    controller: SocioNegocioController
                }
            }
        })



      .state('CuentaList', {
          url: '/CuentaList',
          views: {
              "containerOne": {
                  templateUrl: "Cuenta/List",
                  controller: CuentaController
              }
          }
      })

     .state('ProductoList', {
         url: '/ProductoList',
         views: {
             "containerOne": {
                 templateUrl: "Producto/List",
                 controller: ProductoController
             }
         }
     })
     .state('ProductoCreate', {
         url: '/ProductoCreate',
         views: {
             "containerOne": {
                 templateUrl: "Producto/Create",
                 controller: ProductoController
             }
         }
     })
       .state('DescuentoList', {
           url: '/DescuentoList',
           views: {
               "containerOne": {
                   templateUrl: "Descuento/List",
                   controller: DescuentoController
               }
           }
       })
    .state('DescuentoCreate', {
        url: '/DescuentoCreate',
        views: {
            "containerOne": {
                templateUrl: "Descuento/Create",
                controller: DescuentoController
            }
        }
    })
     .state('DescuentoEdit', {
         url: '/DescuentoEdit',
         views: {
             "containerOne": {
                 templateUrl: "Descuento/Create",
                 controller: DescuentoController
             }
         }
     })
     .state('CategoriaList', {
         url: '/CategoriaList',
         views: {
             "containerOne": {
                 templateUrl: "Categoria/List",
                 controller: CategoriaController
             }
         }
     })
     .state('CategoriaCreate', {
         url: '/CategoriaCreate',
         views: {
             "containerOne": {
                 templateUrl: "Categoria/Create",
                 controller: CategoriaController
             }
         }
     })
     .state('CategoriaEdit', {
         url: '/CategoriaEdit',
         views: {
             "containerOne": {
                 templateUrl: "Categoria/Create",
                 controller: CategoriaController
             }
         }
     })

     .state('SubCategoriaList', {
         url: '/SubCategoriaList',
         views: {
             "containerOne": {
                 templateUrl: "SubCategoria/List",
                 controller: SubCategoriaController
             }
         }
     })
     .state('SubCategoriaCreate', {
         url: '/SubCategoriaCreate',
         views: {
             "containerOne": {
                 templateUrl: "SubCategoria/Create",
                 controller: SubCategoriaController
             }
         }
     })
     .state('SubCategoriaEdit', {
         url: '/SubCategoriaEdit',
         views: {
             "containerOne": {
                 templateUrl: "SubCategoria/Create",
                 controller: SubCategoriaController
             }
         }
     })

     .state('MarcaList', {
         url: '/MarcaList',
         views: {
             "containerOne": {
                 templateUrl: "Marca/List",
                 controller: MarcaController
             }
         }
     })

     .state('MarcaCreate', {
         url: '/MarcaCreate',
         views: {
             "containerOne": {
                 templateUrl: "Marca/Create",
                 controller: MarcaController
             }
         }
     })
     .state('MarcaEdit', {
         url: '/MarcaEdit',
         views: {
             "containerOne": {
                 templateUrl: "Marca/Create",
                 controller: MarcaController
             }
         }
     })

    .state('SucursalList', {
        url: '/SucursalList',
        views: {
            "containerOne": {
                templateUrl: "Sucursal/List",
                controller: SucursalController
            }
        }
    })

     .state('SucursalCreate', {
         url: '/SucursalCreate',
         views: {
             "containerOne": {
                 templateUrl: "Sucursal/Create",
                 controller: SucursalController
             }
         }
     })
     .state('SucursalEdit', {
         url: '/SucursalEdit',
         views: {
             "containerOne": {
                 templateUrl: "Sucursal/Create",
                 controller: SucursalController
             }
         }
     })


     .state('OCList', {
         url: '/OCList',
         views: {
             "containerOne": {
                 templateUrl: "OC/List",
                 controller: OCController
             }
         }
     })

     .state('OCCreate', {
         url: '/OCCreate',
         views: {
             "containerOne": {
                 templateUrl: "OC/Create",
                 controller: OCController
             }
         }
     })
         .state('OCModific', {
             url: '/OCModific',
             views: {
                 "containerOne": {
                     templateUrl: "OC/Modific",
                     controller: OCController
                 }
             }
         })


     .state('OCListAdd', {
         url: '/OCListAdd',
         views: {
             "containerOne": {
                 templateUrl: "OC/ListAdd",
                 controller: OCController
             }
         }
     })
             .state('MovimientoList', {
                 url: '/MovimientoList',
                 views: {
                     "containerOne": {
                         templateUrl: "Movimiento/List",
                         controller: MovimientoController
                     }
                 }
             })
                 .state('MovimientoCreate', {
                     url: '/MovimientoCreate',
                     views: {
                         "containerOne": {
                             templateUrl: "Movimiento/Create",
                             controller: MovimientoController
                         }
                     }
                 })

             .state('DetalleOCModific', {
                 url: '/DetalleOCModific',
                 views: {
                     "containerOne": {
                         templateUrl: "DetalleOC/Modific",
                         controller: DetalleOCController
                     }
                 }
             })

         .state('DetalleOCCreate', {
             url: '/DetalleOCCreate',
             views: {
                 "containerOne": {
                     templateUrl: "DetalleOC/Create",
                     controller: DetalleOCController
                 }
             }
         })
             .state('OCAddListAdd', {
                 url: '/OCAddListAdd',
                 views: {
                     "containerOne": {
                         templateUrl: "OCAdd/ListAdd",
                         controller: OCAddController
                     }
                 }
             })

         .state('OVList', {
             url: '/OVList',
             views: {
                 "containerOne": {
                     templateUrl: "OV/List",
                     controller: OVController
                 }
             }
         })
     .state('OVCreate', {
         url: '/OVCreate',
         views: {
             "containerOne": {
                 templateUrl: "OV/Create",
                 controller: OVController
             }
         }
     })

        .state('StockListAdd', {
            url: '/StockListAdd',
             views: {
                 "containerOne": {
                     templateUrl: "Stock/ListAdd",
                     controller: StockAddController
                 }
             }
        })
    
         .state('OVModific', {
             url: '/OVModific',
             views: {
                 "containerOne": {
                     templateUrl: "OV/Modific",
                     controller: OVController
                 }
             }
         })
             .state('DetalleOVCreate', {
                 url: '/DetalleOVCreate',
                 views: {
                     "containerOne": {
                         templateUrl: "DetalleOV/Create",
                         controller: DetalleOVController
                     }
                 }
             })
                 .state('DetalleOVModific', {
                     url: '/DetalleOVModific',
                     views: {
                         "containerOne": {
                             templateUrl: "DetalleOV/Modific",
                             controller: DetalleOVController
                         }
                     }
                 })

                 .state('MovimientoList2', {
                     url: '/MovimientoList2',
                     views: {
                         "containerOne": {
                             templateUrl: "Movimiento/List2",
                             controller: MovimientoController
                         }
                     }
                 })
                 .state('MovimientoCreate2', {
                     url: '/MovimientoCreate2',
                     views: {
                         "containerOne": {
                             templateUrl: "Movimiento/Create2",
                             controller: MovimientoController
                         }
                     }
                 })

                 .state('OVAddListAdd', {
                     url: '/OVAddListAdd',
                     views: {
                         "containerOne": {
                             templateUrl: "OVAdd/ListAdd",
                             controller: OVAddController
                         }
                     }
                 })
    ;

    //$httpProvider.interceptors.push('AuthHttpResponseInterceptor');
}

configFunction.$inject = ['$stateProvider', '$urlRouterProvider', '$locationProvider', '$httpProvider'];

MetronicApp.controller('GrupoController', GrupoController);

MetronicApp.controller('AlmacenController', AlmacenController);
MetronicApp.controller('AlmacenAddController', AlmacenAddController);
MetronicApp.controller('ListaPrecioController', ListaPrecioController);

MetronicApp.controller('SocioNegocioController', SocioNegocioController);
MetronicApp.controller('SocioNegocioAddController', SocioNegocioAddController);
MetronicApp.controller('SocioNegocioAddClienteController', SocioNegocioAddClienteController);
MetronicApp.controller('CuentaController', CuentaController);
MetronicApp.controller('PrecioController', PrecioController);
MetronicApp.controller('PrecioAddController', PrecioAddController);
MetronicApp.controller('ProductoController', ProductoController);
MetronicApp.controller('ProductoAddController', ProductoAddController);
MetronicApp.controller('DescuentoController', DescuentoController);
MetronicApp.controller('DescuentoAddController', DescuentoAddController);
MetronicApp.controller('CategoriaController', CategoriaController);
MetronicApp.controller('CategoriaAddController', CategoriaAddController);
MetronicApp.controller('SubCategoriaController', SubCategoriaController);
MetronicApp.controller('SubCategoriaAddController', SubCategoriaAddController);
MetronicApp.controller('MarcaController', MarcaController);
MetronicApp.controller('MarcaAddController', MarcaAddController);
MetronicApp.controller('SucursalController', SucursalController);
MetronicApp.controller('OCController', OCController);
MetronicApp.controller('MovimientoController', MovimientoController);
MetronicApp.controller('DetalleOCController', DetalleOCController);
MetronicApp.controller('OCAddController', OCAddController);
MetronicApp.controller('OVController', OVController);
MetronicApp.controller('RequerimientosController', RequerimientosController);
MetronicApp.controller('StockAddController', StockAddController);
MetronicApp.controller('DetalleOVController', DetalleOVController);
MetronicApp.controller('OVAddController', OVAddController);







