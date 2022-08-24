[Point](../../Point.md) > [Status](../Status.md) > [On_Status](#)
# On_Status

**Display name:** On Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:On_Status;1

---


## Child interfaces
* [Overridden_On_Status](../Overridden_Status/Overridden_On_Status.md)
* [On_Off_Status](On_Off_Status/On_Off_Status.md)

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
