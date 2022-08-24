[Asset](../../../Asset.md) > [Equipment](../../Equipment.md) > [HVAC_Equipment](../HVAC_Equipment.md) > [Fan](#)
# Fan

**Display name:** Fan<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Fan;1

---


## Child interfaces
* [Booster_Fan](Booster_Fan.md)
* [Ceiling_Fan](Ceiling_Fan.md)
* [Cooling_Tower_Fan](Cooling_Tower_Fan.md)
* [Discharge_Fan](Discharge_Fan.md)
* [Exhaust_Fan](Exhaust_Fan.md)
* [Outside_Fan](Outside_Fan.md)
* [Relief_Fan](Relief_Fan.md)
* [Return_Fan](Return_Fan.md)
* [Standby_Fan](Standby_Fan.md)
* [Supply_Fan](Supply_Fan.md)
* [Transfer_Fan](Transfer_Fan.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** feeds, isFedBy
* **dtmi:org:w3id:rec:Asset;1:** commissionedBy, documentation, hasPart, hasPoint, installedBy, isPartOf, locatedIn, manufacturedBy, mountedOn, servicedBy
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Equipment;1:** operationalStageCount
* **dtmi:org:w3id:rec:Asset;1:** assetTag, commissioningDate, customTags, externalIds, geometry, initialCost, installationDate, IPAddress, MACAddress, maintenanceInterval, modelNumber, name, serialNumber, turnoverDate, weight
## Target Of
### Inherited
* Asset.hasPart
* Asset.isPartOf
* EquipmentCollection.includes
