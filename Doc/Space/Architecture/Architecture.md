[Space](../Space.md) > [Architecture](.)
# Architecture

A designed/landscaped (or potentially designed/landscaped) part of the physical world that has a 3D spatial extent. E.g., a building site, a building, levels within the building, rooms, etc.


**Display name:** Architecture<br />
**DTMI:** dtmi:org:w3id:rec:Architecture;1

---
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|address|**en**: address|**en**: Physical address of the architecture (site, building, sub-building, entrance room, etc.) in question.|0-Infinity|dtmi:org:w3id:rec:PostalAddress;1||True|
|adjacentElement|**en**: adjacent element||0-Infinity|dtmi:org:w3id:rec:BuildingElement;1||True|
|architectedBy|**en**: architected by||0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
|constructedBy|||0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
|containsElement|**en**: contains element|**en**: Links an Architecture to BuildingElement that is contained in the Space.|0-Infinity|dtmi:org:w3id:rec:BuildingElement;1||True|
|documentation|**en**: documentation||0-Infinity|dtmi:org:w3id:rec:Document;1||True|
|hasPoint|**en**: has point||0-Infinity|dtmi:org:brickschema:schema:Brick:Point;1||True|
|intersectingElement|**en**: intersecting element||0-Infinity|dtmi:org:w3id:rec:BuildingElement;1||True|
|isFedBy|**en**: is fed by||0-Infinity||substance (enum (ACElec, Air, BlowdownWater, ChilledWater, ColdDomesticWater, Condensate, CondenserWater, DCElec, Diesel, DriveElec, Ethernet, ExhaustAir, Freight, FuelOil, Gasoline, GreaseExhaustAir, HotDomesticWater, HotWater, IrrigationWater, Light, MakeupWater, NaturalGas, NonPotableDomesticWater, OutsideAir, People, Propane, RecircHotDomesticWater, Refrig, ReturnAir, SprinklerWater, Steam, StormDrainage, SupplyAir, TransferAir, WasteVentDrainage, Water))|True|
|operatedBy|**en**: operated by||0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
|ownedBy|**en**: owned by||0-Infinity|dtmi:org:w3id:rec:Agent;1||True|
### Inherited Relationships
* **dtmi:org:w3id:rec:Space;1:** hasPart, isLocationOf, isPartOf
## Properties
### Inherited Properties
* **dtmi:org:w3id:rec:Space;1:** customTags, externalIds, geometry, name
## Target Of
### Direct
* BuildingElement.locatedIn
* Campus.includes
### Inherited
* Asset.locatedIn
* Space.hasPart
* Space.isPartOf
