[Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [Meter](../Meter.md) > [Building_Meter](#)
# Building_Meter

**Display name:** Building Meter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Building_Meter;1

---


## Child interfaces
* [Building_Electrical_Meter](../Electrical_Meter/Building_Electrical_Meter.md)
* [Building_Gas_Meter](../Gas_Meter/Building_Gas_Meter.md)
* [Building_Water_Meter](../Water_Meter/Building_Water_Meter.md)
* [Building_Chilled_Water_Meter](../Water_Meter/Chilled_Water_Meter/Building_Chilled_Water_Meter.md)
* [Building_Hot_Water_Meter](../Water_Meter/Hot_Water_Meter/Building_Hot_Water_Meter.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Meter;1:** hasSubMeter, isSubMeterOf
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** feeds, isFedBy
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Meter;1:** isMeteredBy, isVirtualMeter, meters
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** operationalStageCount
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Target Of
### Inherited
* Asset.hasPart
* Asset.isPartOf
* EquipmentCollection.includes
* Meter.hasSubMeter
* Meter.isSubMeterOf
