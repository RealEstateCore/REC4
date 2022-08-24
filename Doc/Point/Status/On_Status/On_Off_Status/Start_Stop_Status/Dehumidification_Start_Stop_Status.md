[Point](../../../../Point.md) > [Status](../../../Status.md) > [On_Status](../../On_Status.md) > [On_Off_Status](../On_Off_Status.md) > [Start_Stop_Status](Start_Stop_Status.md) > [Dehumidification_Start_Stop_Status](.)
# Dehumidification_Start_Stop_Status

**Display name:** Dehumidification Start Stop Status<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Dehumidification_Start_Stop_Status;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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
