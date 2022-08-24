[Point](../../Point.md) > [Status](../Status.md) > [Off_Status](#)
# Off_Status

**Display name:** Off Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Off_Status;1

---


## Child interfaces
* [Overridden_Off_Status](../Overridden_Status/Overridden_Off_Status.md)
* [Emergency_Power_Off_System_Status](../System_Status/Emergency_Power_Off_System_Status/Emergency_Power_Off_System_Status.md)
* [On_Off_Status](../On_Status/On_Off_Status/On_Off_Status.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
