//using System.Collections.Generic;
//using System.Web.Mvc;
//using System.Web.Routing;
//using Orchard.Mvc.Routes;

//public class Routes : IRouteProvider {
//    public void GetRoutes(ICollection<RouteDescriptor> routes) {
//        foreach (var routeDescriptor in GetRoutes())
//            routes.Add(routeDescriptor);
//    }

//    public IEnumerable<RouteDescriptor> GetRoutes() {
//        return new[] {
//            new RouteDescriptor {
//                Priority = 5,
//                Route = new Route("calendarDates" ,
//                                  new RouteValueDictionary {
//                                      {"area", "BizStrap.1.3" },
//                                      {"controller", "Calendar"},
//                                      {"action", "Index"}
//                                  },
//                                  new RouteValueDictionary(),
//                                  new RouteValueDictionary {
//                                      {"area", "BizStrap.1.3"}
//                                  },
//                                  new MvcRouteHandler())
//            },
//            new RouteDescriptor {
//                Priority = 5,
//                Route = new Route("Contents/Accessability/SetContrast" ,
//                                  new RouteValueDictionary {
//                                      {"area", "BizStrap.1.3" },
//                                      {"controller", "Accessability"},
//                                      {"action", "SetContrast"}
//                                  },
//                                  new RouteValueDictionary(),
//                                  new RouteValueDictionary {
//                                      {"area", "BizStrap.1.3"}
//                                  },
//                                  new MvcRouteHandler())
//            },
//            new RouteDescriptor {
//                Priority = 5,
//                Route = new Route("Contents/Accessability/CycleContrast" ,
//                                  new RouteValueDictionary {
//                                      {"area", "BizStrap.1.3" },
//                                      {"controller", "Accessability"},
//                                      {"action", "CycleContrast"}
//                                  },
//                                  new RouteValueDictionary(),
//                                  new RouteValueDictionary {
//                                      {"area", "BizStrap.1.3"}
//                                  },
//                                  new MvcRouteHandler())
//            },
//            new RouteDescriptor {
//                Priority = 5,
//                Route = new Route("Contents/Accessability/SetTextSize" ,
//                                  new RouteValueDictionary {
//                                      {"area", "BizStrap.1.3" },
//                                      {"controller", "Accessability"},
//                                      {"action", "SetTextSize"}
//                                  },
//                                  new RouteValueDictionary(),
//                                  new RouteValueDictionary {
//                                      {"area", "BizStrap.1.3"}
//                                  },
//                                  new MvcRouteHandler())
//            }
//        };
//    }
//}