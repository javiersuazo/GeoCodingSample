# GeoCodingSample

Install via nuget:
```
Install-Package Geocoding.net
```

This is a sample of how geocode addresses using google maps. You just need to create a geocoder object:
 
```
IGeocoder geocoder = new GoogleGeocoder() {ApiKey = "your_api_key" };
```

For getting coordinates from an address, you just need to do this:
```
IEnumerable<Address> addresses = geocoder.Geocode("tegucigalpa honduras");
```
Create any question, issue, or comment here:

[https://github.com/chadly/Geocoding.net]