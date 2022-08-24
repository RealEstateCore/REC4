[Point](../../Point.md) > [Status](../Status.md) > [Fan_Status](.)
# Fan_Status

**Display name:** Fan Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Fan_Status;1

---


## Child interfaces
* [Fan_On_Off_Status](../On_Status/On_Off_Status/Fan_On_Off_Status.md)

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
