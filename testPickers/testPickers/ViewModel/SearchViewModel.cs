
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvvmHelpers;
using testPickers.Model;

namespace testPickers.ViewModel
{
    public class SearchViewModel : BaseViewModel
    {
        private City city;
        private State state;

        public ObservableRangeCollection<State> States { get; set; }
        public ObservableRangeCollection<City> Cities { get; set; }
        public ObservableRangeCollection<Town> Towns { get; set; }

        public SearchViewModel()
        {
            States = new ObservableRangeCollection<State>();
            Cities = new ObservableRangeCollection<City>();
            Towns = new ObservableRangeCollection<Town>();

            GetStates();
        }
        public void GetStates()
        {
            States = new ObservableRangeCollection<State>()
            {
                new State() { StateId = 1, StateName = "USA"},
                new State() { StateId = 2, StateName = "Canada"}
            };
        }
        public void GetCities(int stateId)
        {
            List<City> cities = new List<City>()
            {
                new City() { CityId = 1, CityName = "Dalas", StateId = 1},
                new City() { CityId = 2, CityName = "Boston", StateId = 1},
                new City() { CityId = 3, CityName = "Vancuvour", StateId = 2}
            };

            Cities.ReplaceRange(cities.Where(c => c.StateId == stateId));
        }

        public void GetTowns(int cityId)
        {
            List<Town> towns = new List<Town>()
            {
                new Town() { TownId = 1, TownName = "Town one", CityId = 1},
                new Town() { TownId = 2, TownName = "Town Two", CityId = 2},
                new Town() { TownId = 3, TownName = "Town three", CityId = 2}
            };

            Towns.ReplaceRange(towns.Where(t => t.CityId == cityId));
        }
        public void CityNull()
        {
            List<Town> towns = new List<Town>()
            {
                new Town() { TownId = 1, TownName = "Town one", CityId = 1},
            };
            Towns.ReplaceRange(towns);
        }
        public State State
        {
            get
            {
                return state;
                
            }
            set
            {
                if(state != value)
                {
                    state = value;
                    if (State != null)
                    {
                        GetCities(state.StateId);
                    }
                }
            }
        }
        public City City
        {
            get
            {
                
                return city;
            }
            set
            {
                
                if (city != value)
                {
                    city = value;
                    if (City !=null)
                    {
                        GetTowns(city.CityId);
                    }
                    if(City == null)
                    {
                        CityNull();
                    }
                }
            }
        }
    }
}
