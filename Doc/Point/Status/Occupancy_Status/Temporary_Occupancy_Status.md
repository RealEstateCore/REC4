[Point](../../Point.md) > [Status](../Status.md) > [Occupancy_Status](Occupancy_Status.md) > [Temporary_Occupancy_Status](.)
# Temporary_Occupancy_Status
**DTMI:** dtmi:org:brickschema:schema:Brick:Temporary_Occupancy_Status;1
## Display name
- **en:** Temporary Occupancy Status
## Description
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
