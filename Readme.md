## GovHack 2018

# Challenges
-Bounty: Decision Support
Region: Australia

-Bounty: Making open data more open.
Region: Australia

-Bounty: Is seeing truely believing?
Region: Australia

-Data4Good
Region: New South Wales

-SEED - Open Data with a Purpose
Region: New South Wales


# New Challenges
- More than apps and maps: help government decide with data
How can we combine data to help government make their big and small decisions? Government makes decisions every day—with long term consequences such as the location of a school, or on a small scale such as the rostering of helpdesk staff.

- Save Lives With Data
How can we use data and technology to better the health of the Australian population, and what could be the economic impacts?


# Data Story
What data you have used, how you have used it, and what story does it now tell as part of your project

-IPCC AR4 SEA-LEVEL PROJECTIONS
Description of Use: The Sea-level rise projection from 1990 - 2100 is used to calculate the water rising in and around sydney wet lands.

-Temperature Data
Description of Use: The temperature data set for Parramatta will be used to feed into the visualisation we have for the climate change. We want to use the information and also combine with a data set similar to https://www.climatechangeinaustralia.gov.au/en/climate-projections/explore-data/data-download/gridded-data-download/

-Planning/EPI_Protection_Layers, Flood
Description of Use: Coastal wetlands are most at risk due to climate change. Understanding the impact of climate change and more specifically of sea-level rise on coastal wetlands must take into account factors that affect the ecological balance of wetland ecosystems

-Planning/EPI_Protection_Layers, NSW Coastal Wetlands
Description of Use: Coastal wetlands are most at risk due to climate change. Understanding the impact of climate change and more specifically of sea-level rise on coastal wetlands must take into account factors that affect the ecological balance of wetland ecosystems

-Open Street Maps
Description of Use: Provides base maps on which we provide our solutions. Allows our solution to be used globally

- NarCLIM Data 
url: 
 https://mapprod.environment.nsw.gov.au/arcgis/rest/services/NarCLIM/ClimateRegion/MapServer/1
description:


# How can we ?
- How can open data be presented on search.data.gov.au to make it easier and friendlier to use? 
- Does this mean making it more similar to using standard search engines, like Google, or something else entirely?
- How can we combine data to help government make their big and small decisions? 
- How can we use data and technology to better the health of the Australian population, and what could be the economic impacts?
- How can open data be used to make a social impact, contributing to the betterment of society? How can we improve prospects for children, and education, using open data? 
- What sort of impact can be made on homelessness, mental health outcomes, or the environment, using open data?


# How can the data be improved?
 Existing services provide a great potential for government agencies, citizen scientists and weekened hackers to consume and mashup data from various sources. However we made a few key observations as we consumed this data and have suggestions to make this even more accessible

 Observations & Suggestions for improvement
 - A Common platform for hosting, cleansing, analysing and serving data. While the SEED portal is amazing it draws from various data sources hosted and collected in different formats - a Common platform will help data providers & consumers a single location to share, process, search and analyse gov and citizen data
 
 - While static data is fun, streaming data is the future. As more connected devices and individuals provide this data there needs to be a way to ingest this real time for processing & serving later. Existing technologies like AWS Kinesis, Confluent Kafka Cloud services, Google Cloud PubSub would be used to ingest data into _streams_ for cleansing, processing and storage. There could be multiple consumers to the streams, allowing end consumers to subscribe to real time events
   This also opens up the potential to obtain real-time data from new technologies - smart phone, smart homes, smart cars to make more real-time decisions about our local environment & move the dial the other way faster!   
 
 - Microservices: As we were consuming the data for govhack we found most of the map information is served by a single monolithic product which required subject matter knowledge around the product to query the data. As an open data system, we this as a _hurdle_ to _self-service_ and a not scale. Instead we propose using light-weight services by domains and surfacing map data through more standardised, product agnostic RESTful APIs 

 Perhaps a GraphQL frontend API with a microservice layer over the existing ArcGIS RESTful services. We imagine microservies would be light weight and wrap the SME knowledge around ArcGIC Rest services & have optimised queries, queries by popular regions, relations to other data sets. These domain services would also accept inbound data, batch / real time ( upload streaming NSW costal wetland data for a geometry ) and push it to the data pipelines








